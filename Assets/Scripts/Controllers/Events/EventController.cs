
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class EventController
{
    public delegate void eventHudManager(int value);

    public static eventHudManager addPoints;
    public static eventHudManager removeLife;
}
