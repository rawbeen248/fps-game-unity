var DamageAmount : int ;
var TargetDistance : float;
var AllowedRange : float = 15;
var hit : RaycastHit;
var TheBlood : GameObject;
var TheBloodGreen : GameObject;

function Update () {
if(GlobalAmmo.LoadedAmmo >=1){
    if(Input.GetButtonDown("Fire1")) {

        var Shot : RaycastHit;
            if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), Shot)) {
                TargetDistance = Shot.distance;
                    if (TargetDistance < AllowedRange) {
                        
        if (Physics.Raycast (transform.position, transform.TransformDirection(Vector3.forward), hit)) {
        if (hit.collider.tag == "ZombieHead"){
        Shot.transform.SendMessage("DeductPoints", DamageAmount);
        DamageAmount=10;
        Instantiate(TheBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));}

        if (hit.transform.tag == "Zombie"){
        Shot.transform.SendMessage("DeductPoints", DamageAmount);
        DamageAmount=5;
        Instantiate(TheBlood, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));}
         
        if (hit.transform.tag == "Wolf"){
        Shot.transform.SendMessage("DeductPoints", DamageAmount);
        DamageAmount=5;
        Instantiate(TheBloodGreen, hit.point, Quaternion.FromToRotation(Vector3.up, hit.normal));}

                    }}}}}}
