﻿using UnityEngine;
using System.Collections;

public class Goliath : Unit {

	void Start () {
        Name = "Goliath";
        parameters.moveAlgorithm = Unit.MoveAlgorithms.Jump;
        SetMoveAlgorithm(typeof(TerranJumpMoveAlgorithm));
	}
}
