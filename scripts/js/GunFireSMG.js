var TheSMG : GameObject;
var SMGSound : AudioSource;
var MuzzleFlash : GameObject;
var AmmoCount : int;
var Firing : int;

var UpCurs : GameObject;
var DownCurs : GameObject;
var LeftCurs : GameObject;
var RightCurs : GameObject;

function Update () {
    AmmoCount = GlobalAmmo.LoadedAmmo;


    if (Input.GetButton("Fire1")) {
        if (AmmoCount >= 1) {
            if (Firing == 0) {
                SMGFire();
            }
        }
    }
}

function SMGFire() {
        Firing = 1;
        UpCurs.GetComponent("Animator").enabled=true;
        DownCurs.GetComponent("Animator").enabled=true;
        LeftCurs.GetComponent("Animator").enabled=true;
        RightCurs.GetComponent("Animator").enabled=true;
        GlobalAmmo.LoadedAmmo -= 1;
        SMGSound.Play();
        MuzzleFlash.SetActive(true);
        TheSMG.GetComponent("Animator").enabled = true;
        yield WaitForSeconds(0.1);
        MuzzleFlash.SetActive(false);
        TheSMG.GetComponent("Animator").enabled = false;
        UpCurs.GetComponent("Animator").enabled=false;
        DownCurs.GetComponent("Animator").enabled=false;
        LeftCurs.GetComponent("Animator").enabled=false;
        RightCurs.GetComponent("Animator").enabled=false;
        Firing = 0;
} 
