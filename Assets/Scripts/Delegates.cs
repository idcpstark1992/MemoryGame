using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Delegates 
{
    public delegate void Delegate_OnVerification(bool _Match);
    public static Delegate_OnVerification Listener_OnVerification;
}
