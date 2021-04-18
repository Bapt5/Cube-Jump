#pragma strict

var ShowGUI : boolean = false;
var canvas : GameObject;
var panel : GameObject;
var player : GameObject;

function Update () {
    Cursor.visible = false;
    canvas.SetActive(false);
    player.SetActive(true);
    panel.SetActive(false);
    if(Input.GetKeyDown(KeyCode.Escape)){
        ShowGUI=!ShowGUI;
    }
    if(ShowGUI==true){
        Cursor.visible = true;
        canvas.SetActive(true);
        panel.SetActive(true);
        player.SetActive(false);
        AudioListener.volume = 0;
        Time.timeScale = 0;
    }else{
        Cursor.visible = false;
        canvas.SetActive(false);
        panel.SetActive(false);
        player.SetActive(true);
        AudioListener.volume = 1;
        Time.timeScale = 1;
    }
}
function REPRENDRE (){
        ShowGUI=!ShowGUI;
}