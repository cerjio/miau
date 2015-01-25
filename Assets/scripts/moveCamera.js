#pragma strict

function Start () {

}

function Update () {
 transform.position.x = Mathf.Clamp (transform.position.x, -10.7, 8.7);
}