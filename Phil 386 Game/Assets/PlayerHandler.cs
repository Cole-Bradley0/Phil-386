using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHandler : MonoBehaviour
{
    public Text _moneyText;
    public Image _reputationBar;
    public Image _reputationBarHolder;
    public int _money;
    public int _reputation;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        _moneyText.text = "$"+_money;
        
        _reputationBar.rectTransform.sizeDelta = new Vector2(_reputation, 50);
    }
}
