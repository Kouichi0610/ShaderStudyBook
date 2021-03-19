using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class Hello
{
    // A Test behaves as an ordinary method
    [Test]
    public void HelloSimplePasses()
    {
        var forward = new Vector3(0,0,1);
        var up = new Vector3(0,1,0);

        var res = Vector3.Dot(forward, up);
        Assert.That(res, Is.EqualTo(0.0f));
    }
    [Test]
    public void 内積() {
        var a = new Vector3(0,0,1.0f);
        var b = new Vector3(0,1.0f,1.0f);
        var res = Vector3.Dot(a, b);
        Assert.That(res, Is.EqualTo(0.5f));
    }
    public int Add(int a, int b) {
        return a + b;
    }
}
