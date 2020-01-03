﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeImp.DoomBuilder.Rendering
{
    public struct Vector4f
    {
        public Vector4f(float v)
        {
            X = v;
            Y = v;
            Z = v;
            W = v;
        }

        public Vector4f(Vector2f xy, float z, float w)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        public Vector4f(Vector3f xyz, float w)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        public Vector4f(float x, float y, float z, float w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public float X;
        public float Y;
        public float Z;
        public float W;

        public override bool Equals(object o)
        {
            if (o is Vector4f)
            {
                Vector4f v = (Vector4f)o;
                return this == v;
            }
            else
            {
                return false;
            }
        }

        public static Vector4f operator +(Vector4f left, Vector4f right)
        {
            return new Vector4f(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        public static Vector4f operator -(Vector4f left, Vector4f right)
        {
            return new Vector4f(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        public static Vector4f operator -(Vector4f v)
        {
            return new Vector4f(-v.X, -v.Y, -v.Z, -v.W);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + W.GetHashCode();
        }

        public static bool operator ==(Vector4f left, Vector4f right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        }

        public static bool operator !=(Vector4f left, Vector4f right)
        {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
        }
    }

    public struct Vector4i
    {
        public Vector4i(int v)
        {
            X = v;
            Y = v;
            Z = v;
            W = v;
        }

        public Vector4i(Vector2i xy, int z, int w)
        {
            X = xy.X;
            Y = xy.Y;
            Z = z;
            W = w;
        }

        public Vector4i(Vector3i xyz, int w)
        {
            X = xyz.X;
            Y = xyz.Y;
            Z = xyz.Z;
            W = w;
        }

        public Vector4i(int x, int y, int z, int w)
        {
            X = x;
            Y = y;
            Z = z;
            W = w;
        }

        public int X;
        public int Y;
        public int Z;
        public int W;

        public override bool Equals(object o)
        {
            if (o is Vector4i)
            {
                Vector4i v = (Vector4i)o;
                return this == v;
            }
            else
            {
                return false;
            }
        }

        public static Vector4i operator +(Vector4i left, Vector4i right)
        {
            return new Vector4i(left.X + right.X, left.Y + right.Y, left.Z + right.Z, left.W + right.W);
        }

        public static Vector4i operator -(Vector4i left, Vector4i right)
        {
            return new Vector4i(left.X - right.X, left.Y - right.Y, left.Z - right.Z, left.W - right.W);
        }

        public static Vector4i operator -(Vector4i v)
        {
            return new Vector4i(-v.X, -v.Y, -v.Z, -v.W);
        }

        public override int GetHashCode()
        {
            return X.GetHashCode() + Y.GetHashCode() + Z.GetHashCode() + W.GetHashCode();
        }

        public static bool operator ==(Vector4i left, Vector4i right)
        {
            return left.X == right.X && left.Y == right.Y && left.Z == right.Z && left.W == right.W;
        }

        public static bool operator !=(Vector4i left, Vector4i right)
        {
            return left.X != right.X || left.Y != right.Y || left.Z != right.Z || left.W != right.W;
        }
    }
}
