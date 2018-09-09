using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;


public class UIController : MonoBehaviour
{

    [SerializeField] private GameObject _gameplayUI;
    [SerializeField] private Text _seaLevelLabel;
    [SerializeField] private float _seaLevel;
    [SerializeField] private GameObject _seaLevelGameObject;
    Vector3 sealLevelPosition;

    private void Awake()
    {
        Assert.IsNotNull(_gameplayUI);
        Assert.IsNotNull(_seaLevelGameObject);

    }

    // Use this for initialization
    void Start()
    {

        //Assert.IsNotNull(GameManager.Instance);
    }

    // Update is called once per frame
    void Update()
    {
        if (_gameplayUI.activeSelf)
        {
            UpdateSeaLevel();
        }
    }

    private void UpdateSeaLevel()
    {
        sealLevelPosition = _seaLevelGameObject.transform.position;
        sealLevelPosition.y = _seaLevel;
        _seaLevelGameObject.transform.position = sealLevelPosition;
    }


    public void SealLevelSliderChanged(float newSeaLevel) {
        _seaLevelLabel.text = newSeaLevel.ToString("N4");
        _seaLevel = newSeaLevel;
    }

}
