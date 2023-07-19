var EnemyHealth : int = 30;
var TheWolf : GameObject;

function DeductPoints (DamageAmount : int) {
    EnemyHealth -= DamageAmount;
}

function Update () {
    if (EnemyHealth <= 0) {
        this.GetComponent("WolfFollow").enabled=false;

        EndWolf();

    }
}

function EndWolf () {
    yield WaitForSeconds(0.25);
    Destroy(gameObject);
}
