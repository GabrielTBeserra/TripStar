using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Interfaces.Player
{
    public interface IRigidBody
    {
        Rigidbody2D GetRigidBody2D();
    }
}
