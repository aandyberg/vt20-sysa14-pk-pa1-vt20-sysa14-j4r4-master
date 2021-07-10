package org.rentacar;

public class WebServiceAss5SoapProxy implements org.rentacar.WebServiceAss5Soap {
  private String _endpoint = null;
  private org.rentacar.WebServiceAss5Soap webServiceAss5Soap = null;
  
  public WebServiceAss5SoapProxy() {
    _initWebServiceAss5SoapProxy();
  }
  
  public WebServiceAss5SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServiceAss5SoapProxy();
  }
  
  private void _initWebServiceAss5SoapProxy() {
    try {
      webServiceAss5Soap = (new org.rentacar.WebServiceAss5Locator()).getWebServiceAss5Soap();
      if (webServiceAss5Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServiceAss5Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServiceAss5Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServiceAss5Soap != null)
      ((javax.xml.rpc.Stub)webServiceAss5Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.rentacar.WebServiceAss5Soap getWebServiceAss5Soap() {
    if (webServiceAss5Soap == null)
      _initWebServiceAss5SoapProxy();
    return webServiceAss5Soap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (webServiceAss5Soap == null)
      _initWebServiceAss5SoapProxy();
    return webServiceAss5Soap.helloWorld();
  }
  
  public java.lang.String addEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String eMail) throws java.rmi.RemoteException{
    if (webServiceAss5Soap == null)
      _initWebServiceAss5SoapProxy();
    return webServiceAss5Soap.addEmployee(no, firstName, lastName, jobTitle, eMail);
  }
  
  public java.lang.String removeEmployee(java.lang.String no) throws java.rmi.RemoteException{
    if (webServiceAss5Soap == null)
      _initWebServiceAss5SoapProxy();
    return webServiceAss5Soap.removeEmployee(no);
  }
  
  public java.lang.String updateEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String eMail) throws java.rmi.RemoteException{
    if (webServiceAss5Soap == null)
      _initWebServiceAss5SoapProxy();
    return webServiceAss5Soap.updateEmployee(no, firstName, lastName, jobTitle, eMail);
  }
  
  public org.rentacar.Employee searchEmployee(java.lang.String no) throws java.rmi.RemoteException{
    if (webServiceAss5Soap == null)
      _initWebServiceAss5SoapProxy();
    return webServiceAss5Soap.searchEmployee(no);
  }
  
  
}