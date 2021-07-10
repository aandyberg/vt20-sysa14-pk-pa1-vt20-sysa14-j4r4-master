package org.rentacar;

public class WebService3SoapProxy implements org.rentacar.WebService3Soap {
  private String _endpoint = null;
  private org.rentacar.WebService3Soap webService3Soap = null;
  
  public WebService3SoapProxy() {
    _initWebService3SoapProxy();
  }
  
  public WebService3SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebService3SoapProxy();
  }
  
  private void _initWebService3SoapProxy() {
    try {
      webService3Soap = (new org.rentacar.WebService3Locator()).getWebService3Soap();
      if (webService3Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webService3Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webService3Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webService3Soap != null)
      ((javax.xml.rpc.Stub)webService3Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.rentacar.WebService3Soap getWebService3Soap() {
    if (webService3Soap == null)
      _initWebService3SoapProxy();
    return webService3Soap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (webService3Soap == null)
      _initWebService3SoapProxy();
    return webService3Soap.helloWorld();
  }
  
  public java.lang.String rentacar(java.lang.String rentacar) throws java.rmi.RemoteException{
    if (webService3Soap == null)
      _initWebService3SoapProxy();
    return webService3Soap.rentacar(rentacar);
  }
  
  
}