﻿using System;
using System.Collections.Generic;

namespace AvancePruebasUnitarias
{
	public class Tower
	{
		public List<Levels> tower = new List<Levels>();
		Random rnd = new Random();		

		public Tower()
		{
			GenerateTower(GenerateRandomSize());
		}

		public int GenerateRandomSize()
        {
			return (rnd.Next(1, 6));
		}

		public void GenerateTower(int size)
        {
						
            for (int i = 0; i < size; i++)
            {
				tower.Add(null);
            }

			if(size <= 0) throw new Exception("Out of range");
        }

	}
}
