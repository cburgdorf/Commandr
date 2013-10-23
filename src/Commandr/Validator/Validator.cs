﻿using System;

namespace Commandr.Validator
{
	public class Validator
	{
		public static IValidator Integer { get; set; }
		public static IValidator Array { get; set; }
		
		static Validators()
		{
			Validators.Integer = new IntegerValidator();
			Validators.Array = new ArrayValidator();
		}
	}
}