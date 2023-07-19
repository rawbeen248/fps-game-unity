public var FinaScore : int;

var ScoreText : GameObject;

function Update () {
    FinaScore = GlobalScore.CurrentScore;
    ScoreText.GetComponent.<Text>().text = "" +FinaScore;
}
