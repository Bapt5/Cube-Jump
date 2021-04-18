#pragma strict

var plateform : GameObject;

function OnTriggerEnter2D (other : Collider2D) {

    if(other.tag == "Player") {
        
        plateform.GetComponent.<Rigidbody2D>().isKinematic = false;
    }
}
