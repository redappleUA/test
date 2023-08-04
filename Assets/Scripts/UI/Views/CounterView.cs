using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI _text;

    private int _score = 0;
    public int Score
    {
        get { return _score; }
        set
        {
            ChangeCount(value);
            _score = value;
        }
    }

    public void ChangeCount(int count)
    {
        _text.text = count.ToString();
    }
}
