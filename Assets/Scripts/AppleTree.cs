using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Unity.VisualScripting;
using UnityEngine.Assertions;

public class AppleTree : MonoBehaviour
{ 
    [Header("Inscribed")]
    [SerializeField] private GameObject Apple;
    [SerializeField] private GameObject RottenApple;
    // Start is called before the first frame update
    public float speed = 1f; //speed apple tree moves
    public float leftAndRightEdge = 10f; //Distance where apple tree turns around
    public float changeDirChance = 0.1f; //Chance apple tree will change directions
    public float appleDropDelay = 1f; //Seconds between apples instantiations

    void Start()
    {
      Invoke("DropApple", 2f);
    }
    void DropApple(){
      GameObject apple = Instantiate<GameObject>(Apple);
      apple.transform.position = transform.position;
      Invoke("DropApple", appleDropDelay);
    }

    void Update()
    {
      Vector3 pos = transform.position;
      pos.x += speed * Time.deltaTime;
      transform.position = pos;

      if (pos.x < -leftAndRightEdge){
          speed = Mathf.Abs(speed); //Right
      }
      else if (pos.x > leftAndRightEdge){
        speed = -Mathf.Abs(speed); //Left
      }
      //else if (Random.value < changeDirChance){
        //speed *= -1; //Change direction
      //}
    
    }
    void FixedUpdate() {
    if (Random.value < changeDirChance){
        speed *= -1; //Change direction   
    }
  }
}
