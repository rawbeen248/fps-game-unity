var exiit:UnityEngine.SceneManagement.SceneManager;



function Exit () {

         exiit.LoadScene(4);
         }
 function OnDestroy() {
GlobalScore.CurrentScore=0;
GlobalAmmo.LoadedAmmo=0;
GlobalAmmo.CurrentAmmo=0;
} 
