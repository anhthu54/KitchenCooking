using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IHasProgress<T> where T : EventArgs
{
    event EventHandler<T> OnProgressChanged;
}

public class OnProgressChangedEventArgs : EventArgs {
    public float progressNormalized;
}
