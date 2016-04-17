using UnityEngine;
using System.Collections;

public class Room : MonoBehaviour
{

    public HallEditor editor;

    // Use this for initialization
    void Start()
    {
        editor = GameObject.Find("Editor").GetComponent<HallEditor>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void hideForwardWall()
    {
        gameObject.GetComponent<Animator>().SetTrigger("ForwardWall");
    }

    public void deactivateForwardWall()
    {
        gameObject.transform.FindChild("WallF").gameObject.SetActive(false);
    }

    public void hideBackWall()
    {
        gameObject.GetComponent<Animator>().SetTrigger("BackWall");
    }

    public void deactivateBackWall()
    {
        gameObject.transform.FindChild("WallB").gameObject.SetActive(false);
    }

    public void hideRightdWall()
    {
        gameObject.GetComponent<Animator>().SetTrigger("RightWall");
    }

    public void deactivateRightWall()
    {
        gameObject.transform.FindChild("WallR").gameObject.SetActive(false);
    }

    public void hideLeftWall()
    {
        gameObject.GetComponent<Animator>().SetTrigger("LeftWall");
    }

    public void deactivateLeftWall()
    {
        gameObject.transform.FindChild("WallL").gameObject.SetActive(false);
    }

    public void createRoom()
    {
        editor.createRoom(gameObject);
    }
}
