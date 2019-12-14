using UnityEngine;

public class BillboardEdit : MonoBehaviour
{
    private TouchScreenKeyboard _keyboard;
    private TagAlong _tagAlong;

    void Update()
    {
        if (TouchScreenKeyboard.visible == false && IsKeyboardClosed())
        {
            var wasCanceled = _keyboard.wasCanceled;
            var keyboardText = _keyboard.text;

            _keyboard = null;
            if (wasCanceled)
                return;

            _tagAlong.Interactable.Text = keyboardText;
            _tagAlong.Interactable.UpdateBilboardText();
        }
    }

    public void OnSelect()          { OpenKeyboard(); }
    private bool IsKeyboardClosed() { return _keyboard.done == true; }

    private void OpenKeyboard()
    {
        var par;
        if (_tagAlong.Interactable.Text != null) {
            par = _tagAlong.Interactable.Text;
        } else {
            par = "";
        }
        _keyboard = TouchScreenKeyboard.Open(
            par, 
            TouchScreenKeyboardType.Default, 
            false, 
            false, 
            false, 
            false, 
            "Add details"
        );
    }
}
