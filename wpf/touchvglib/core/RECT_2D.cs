//------------------------------------------------------------------------------
// <auto-generated />
//
// This file was automatically generated by SWIG (http://www.swig.org).
// Version 3.0.5
//
// Do not make changes to this file unless you know what you are doing--modify
// the SWIG interface file instead.
//------------------------------------------------------------------------------

namespace touchvg.core {

public class RECT_2D : global::System.IDisposable {
  private global::System.Runtime.InteropServices.HandleRef swigCPtr;
  protected bool swigCMemOwn;

  internal RECT_2D(global::System.IntPtr cPtr, bool cMemoryOwn) {
    swigCMemOwn = cMemoryOwn;
    swigCPtr = new global::System.Runtime.InteropServices.HandleRef(this, cPtr);
  }

  internal static global::System.Runtime.InteropServices.HandleRef getCPtr(RECT_2D obj) {
    return (obj == null) ? new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero) : obj.swigCPtr;
  }

  ~RECT_2D() {
    Dispose();
  }

  public virtual void Dispose() {
    lock(this) {
      if (swigCPtr.Handle != global::System.IntPtr.Zero) {
        if (swigCMemOwn) {
          swigCMemOwn = false;
          touchvgPINVOKE.delete_RECT_2D(swigCPtr);
        }
        swigCPtr = new global::System.Runtime.InteropServices.HandleRef(null, global::System.IntPtr.Zero);
      }
      global::System.GC.SuppressFinalize(this);
    }
  }

  public float left {
    set {
      touchvgPINVOKE.RECT_2D_left_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.RECT_2D_left_get(swigCPtr);
      return ret;
    } 
  }

  public float top {
    set {
      touchvgPINVOKE.RECT_2D_top_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.RECT_2D_top_get(swigCPtr);
      return ret;
    } 
  }

  public float right {
    set {
      touchvgPINVOKE.RECT_2D_right_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.RECT_2D_right_get(swigCPtr);
      return ret;
    } 
  }

  public float bottom {
    set {
      touchvgPINVOKE.RECT_2D_bottom_set(swigCPtr, value);
    } 
    get {
      float ret = touchvgPINVOKE.RECT_2D_bottom_get(swigCPtr);
      return ret;
    } 
  }

  public RECT_2D() : this(touchvgPINVOKE.new_RECT_2D(), true) {
  }

  public float width() {
    float ret = touchvgPINVOKE.RECT_2D_width(swigCPtr);
    return ret;
  }

  public float height() {
    float ret = touchvgPINVOKE.RECT_2D_height(swigCPtr);
    return ret;
  }

}

}