using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Scrap_mechanic_ROM_builder__BIN_2_ROM_;

//idk why i made this a full class but whatever...
public class Vector3I
{
	public int X { get; set; }
	public int Y { get; set; }
	public int Z { get; set; }

	public Vector3I() : this(0) { }

	public Vector3I(int w) => X = Y = Z = w;

	public Vector3I(int x, int y, int z)
	{
		X = x;
		Y = y;
		Z = z;
	}

	public static Vector3I operator +(Vector3I a, Vector3I b) => new (a.X + b.X, a.Y + b.Y, a.Z + b.Z);

	public static Vector3I operator -(Vector3I a, Vector3I b) => new (a.X - b.X, a.Y - b.Y, a.Z - b.Z);

	public static Vector3I operator *(Vector3I vector, int scalar) => new (vector.X * scalar, vector.Y * scalar, vector.Z * scalar);

	public static Vector3I operator /(Vector3I vector, int divisor) => new (vector.X / divisor, vector.Y / divisor, vector.Z / divisor);

	public static implicit operator Vector3I(Vector3 vector) => new((int)vector.X, (int)vector.Y, (int)vector.Z);

	public static implicit operator Vector3(Vector3I vector) => new(vector.X, vector.Y, vector.Z);

	public override string ToString() => $"({X}, {Y}, {Z})";
}
