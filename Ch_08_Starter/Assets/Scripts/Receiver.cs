using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface Receiver
{
    void Move(Direction direction);
    void Shoot();
    void Melee();
    void Block();
}