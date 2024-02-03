using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adventuregamescript : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State stateNow;
    // Start is called before the first frame update
    void Start()
    {
        stateNow = startingState;
        textComponent.text = stateNow.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        updateState();
    }

    private void updateState()
    {
        var nextStates = stateNow.GetNextStates();
        for (int index = 0; index < nextStates.Length; index ++)
        {
            if (Input.GetKeyDown(KeyCode.Keypad1 + index))
            {
                stateNow = nextStates[index];
            }
        }
        textComponent.text = stateNow.GetStateStory();
    }
}
