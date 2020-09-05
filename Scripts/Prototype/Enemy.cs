using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, ICopyable
{
    public ICopyable Copy()
    {
        return Instantiate(this);
        //return (ICopyable)Instantiate(Resource.Load(this.name)); // Fails, Specified cast is not valid. If remove cast, says an explicit cast exists.
    }
}
