﻿namespace GeometryUtils;

/// <summary>
/// Вспомогательный класс с геометрическими операциями.
/// </summary>
public static class GeometryUtility
{
    /// <summary>
    /// Возвращает угол между двумя векторами ab и bc
    /// </summary>
    /// <param name="a">Точка вектора ab</param>
    /// <param name="b">Точка пересечения векторов ab и bc</param>
    /// <param name="c">Точка вектора bc</param>
    /// <returns>Угол между векторами</returns>
    public static float GetAngle(Point2 a, Point2 b, Point2 c)
    {
        // переводим в векторные координаты
        float BAx = a.X - b.X;
        float BAy = a.Y - b.Y;
        float BCx = c.X - b.X;
        float BCy = c.Y - b.Y;

        // скалярное произведение
        float dot_product = BAx * BCx + BAy * BCy;

        // векторное произведение
        float cross_product = BAx * BCy - BAy * BCx;

        // считаем угол
        return (float)Math.Atan2(cross_product, dot_product);
    }

    /// <summary>
    /// Проверяет, находится ли точка внутри области, ограниченной набором вершин.
    /// Для проверки используется следующий принцип: сумма всех углов между точкой и двумя смежными 
    /// вершинами полигона будет равна -2Pi или 2Pi, если точка внутри полигона и близка к 0, если 
    /// точка лежит за пределами полигона.
    /// </summary>
    /// <param name="point">Точка</param>
    /// <param name="polygon">Вершины полигона</param>
    /// <returns>true, если точка внутри полигона</returns>
    public static bool IsPointInsidePolygon(Point2 point, List<Point2> polygon)
    {
        float totalAngle = GetAngle(polygon.Last(), point, polygon.First());
        for (int i = 0; i < polygon.Count() - 1; i++)
            totalAngle += GetAngle(polygon[i], point, polygon[i + 1]);
        float a = Math.Abs(totalAngle);
        return Math.Abs(totalAngle) > 1;
    }

    /// <summary>
    /// Находит точку пересечения прямых ab и cd.
    /// Строится уравнение прямой для общего случая, и когда векторы коллинеарны, но не равны.
    /// </summary>
    /// <param name="a">точка внутри полигона</param>
    /// <param name="b">предыдущее местоположение</param>
    /// <param name="c">первая точка сегманта</param>
    /// <param name="d">вторая точка сегмента</param>
    /// <returns>Точка пересечения прямых ab и cd</returns>
    public static Point2 StraightLinesIntersection(Point2 a, Point2 b, Point2 c, Point2 d)
    {
        float X = 0, Y = 0;
 
        float lambda = (a.X - b.X) / (a.Y - b.Y);
        float gamma = (c.X - d.X) / (c.Y - d.Y);
 
        if (a.X == b.X)
        {
            X = a.X;
            Y = (X - c.X) / gamma + c.Y;
        }
 
        if (a.Y == b.Y)
        {
            Y = a.Y;
            X = (Y - c.Y) * gamma + c.X;
        }
 
        if (c.X == d.X)
        {
            X = d.X;
            Y = (X - a.X) / lambda + a.Y;
        }
 
        if (c.Y == d.Y)
        {
            Y = c.Y;
            X = (Y - a.Y) * lambda + a.X;
        }
 
        if (a.X != b.X && a.Y != b.Y && c.X != d.X && c.Y != d.Y)
        {
            Y = (a.Y * lambda - c.Y * gamma - a.X + c.X) / (lambda - gamma);
            X = (Y - a.Y) * lambda + a.X;
        }
 
        return new Point2(X, Y);
     }
}
