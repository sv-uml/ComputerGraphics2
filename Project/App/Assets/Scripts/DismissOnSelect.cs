using UnityEngine;

public class DismissOnSelect : MonoBehaviour {
    public void OnSelect() {
        Destroy(gameObject);
    }
}