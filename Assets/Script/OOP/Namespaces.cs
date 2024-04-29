using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace Ball_m
{
    public class BallMovement : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(" BallMovement script started ");
        }

        void Update()
        {
            Debug.Log(" BallMovement script updating ");
        }
    }

    public class BallInventory : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(" BallInventory script started ");
        }

        void Update()
        {
            Debug.Log(" BallInventory script updating ");
        }
    }
}

namespace Game
{
    public class GameManager : MonoBehaviour
    {
        void Start()
        {
            Debug.Log(" GameManager script started ");
        }

        void Update()
        {
            Debug.Log(" GameManager script updating ");
        }
    }
}

public class Namespaces : MonoBehaviour
{
    void Start()
    {
        Ball_m.BallMovement ballMovement = gameObject.AddComponent<Ball_m.BallMovement>();

        Game.GameManager gameManager = gameObject.AddComponent<Game.GameManager>();
    }
}