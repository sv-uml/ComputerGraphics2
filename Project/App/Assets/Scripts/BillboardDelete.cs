using UnityEngine;

public class BillboardDelete : MonoBehaviour {
    public void Delete() {
        Destroy(FindObjectOfType<TagAlong>().StickyNote);
        Destroy(FindObjectOfType<TagAlong>().gameObject);
    }
}
