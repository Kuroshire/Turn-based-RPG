using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectorHandler : MonoBehaviour
{
    [SerializeField] Selector selector;
    [SerializeField] List<Transform> selectionable;

    Transform currentSelect;
    int index;

    private void Start() {
        setCurrentSelect(0);
        nextSelect();
    }


    public void nextSelect(){
        setCurrentSelect(index+1);
    }

    public Transform getCurrentSelect(){
        return currentSelect;
    }

    public void setSelectionable(List<Transform> newList){
        selectionable = newList;
        setCurrentSelect(0);
    }

//------------------------------PRIVATE METHODS-----------------------------

    private void setCurrentSelect(int i){
        if(index > selectionable.Count){
            pingIndexLoop();
        }
        index = (i % selectionable.Count);
        currentSelect = selectionable[index];

        moveSelector();
    }

    private void moveSelector(){
        Vector3 newPos = getCurrentSelect().position;
        newPos.z = 0;
        selector.setPosition(newPos);
    }

    private void pingIndexLoop(){
        print("looping lel");
    }

}
