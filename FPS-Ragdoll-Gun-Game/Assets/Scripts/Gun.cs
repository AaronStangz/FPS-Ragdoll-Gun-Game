using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System.Security.Cryptography;
using static UnityEngine.GraphicsBuffer;

public class Gun: MonoBehaviour
{
    [Header("Bullet")]
    public GameObject bullet;

    [Header("Bullet Force")]
    public float shootForce, upwardForce;

    [Header("Gun Stats")]
    public float timeBetweenShooting, spread, reloadTime, timeBetweenShots;
    public int magazineSize, bulletsPerTap;
    public bool allowButtonHold;

    int bulletsLeft, bulletsShot;

    [Header("Recoil")]
    public Rigidbody playerRb;
    public float recoilForce;
    public float recoilOnCam;

    [Header("Bools")]
    bool shooting, readyToShoot, reloading;
    public bool wEquipped;

    [Header("Ref")]
    public Transform attackPoint;
    public Transform cameraTransform;
    public Transform Mid;

    [Header("CamShake")]
    public AnimationCurve curve;
    public float shakeDuration = 1f;

    [Header("Graphics")]
    public GameObject muzzleFlash;
    public TextMeshProUGUI ammunitionDisplay;


    public bool allowInvoke = true;

    private void Awake()
    {
        //playerRb = GetComponent<Rigidbody>();
        bulletsLeft = magazineSize;
        readyToShoot = true;
    }

    private void Update()
    {
        if (playerRb != null && Mid != null)
        {
            MyInput();
            if (ammunitionDisplay != null)
            {
                ammunitionDisplay.SetText(bulletsLeft / bulletsPerTap + " / " + magazineSize / bulletsPerTap);
                if (reloading == true) 
                {
                    ammunitionDisplay.SetText(" Reloading ");
                }
                else
                    ammunitionDisplay.SetText(bulletsLeft / bulletsPerTap + " / " + magazineSize / bulletsPerTap);
            }

        } 
    }
    private void MyInput()
    {
        if (allowButtonHold) shooting = Input.GetKey(KeyCode.Mouse0);
        else shooting = Input.GetKeyDown(KeyCode.Mouse0);

        if (Input.GetKeyDown(KeyCode.R) && bulletsLeft < magazineSize && !reloading) Reload();

        if (readyToShoot && shooting && !reloading && bulletsLeft <= 0) Reload();

        if (readyToShoot && shooting && !reloading && bulletsLeft > 0)
        {
            bulletsShot = 0;

            Shoot();
        }
    }

    private void Shoot()
    {
        readyToShoot = false;

        Ray ray = Camera.main.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0)); 
        RaycastHit hit;


        Vector3 targetPoint;
        if (Physics.Raycast(ray, out hit))
            targetPoint = hit.point;
        else
            targetPoint = ray.GetPoint(75); 

        Vector3 directionWithoutSpread = targetPoint - attackPoint.position;

        float x = Random.Range(-spread, spread);
        float y = Random.Range(-spread, spread);

        Vector3 directionWithSpread = directionWithoutSpread + new Vector3(x, y, 0); 

        GameObject currentBullet = Instantiate(bullet, attackPoint.position, Quaternion.identity); 
        currentBullet.transform.forward = directionWithSpread.normalized;

        currentBullet.GetComponent<Rigidbody>().AddForce(directionWithSpread.normalized * shootForce, ForceMode.Impulse);
        currentBullet.GetComponent<Rigidbody>().AddForce(Camera.main.transform.up * upwardForce, ForceMode.Impulse);

        if (muzzleFlash != null)
            Instantiate(muzzleFlash, attackPoint.position, Quaternion.identity);

        bulletsLeft--;
        bulletsShot++;

        if (allowInvoke)
        {
            Invoke("ResetShot", timeBetweenShooting);
            allowInvoke = false;

            playerRb.AddForce(-directionWithSpread.normalized * recoilForce, ForceMode.Impulse);
            //StartCoroutine(CamShake());
           // Camera.main.transform.rotation = Quaternion.Euler(recoilOnCam, 0, 0);
        }

        if (bulletsShot < bulletsPerTap && bulletsLeft > 0)
            Invoke("Shoot", timeBetweenShots);
    }
    private void ResetShot()
    {
        readyToShoot = true;
        allowInvoke = true;
    }

    private void Reload()
    {
        reloading = true;
        Invoke("ReloadFinished", reloadTime); 
    }
    private void ReloadFinished()
    {
        bulletsLeft = magazineSize;
        reloading = false;
    }

    //IEnumerator CamShake()
   // {
   //     Vector3 startPosition = Mid.transform.position;
    //    float elapsedTime = 0f;
    //
     //   while (elapsedTime < shakeDuration)
    //    {
     //       elapsedTime += Time.deltaTime;
    //        float streangth = curve.Evaluate(elapsedTime / shakeDuration);
     //       transform.position = startPosition + Random.insideUnitSphere * streangth;
     //       yield return null;
    //    }
   // }
}
