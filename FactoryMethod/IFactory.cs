﻿using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
	interface IFactory
	{
		OperationSuper CreateOperation();
	}
}
