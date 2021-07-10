package org.rentacar;

public class WebServiceAssignment4SoapProxy implements org.rentacar.WebServiceAssignment4Soap {
  private String _endpoint = null;
  private org.rentacar.WebServiceAssignment4Soap webServiceAssignment4Soap = null;
  
  public WebServiceAssignment4SoapProxy() {
    _initWebServiceAssignment4SoapProxy();
  }
  
  public WebServiceAssignment4SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServiceAssignment4SoapProxy();
  }
  
  private void _initWebServiceAssignment4SoapProxy() {
    try {
      webServiceAssignment4Soap = (new org.rentacar.WebServiceAssignment4Locator()).getWebServiceAssignment4Soap();
      if (webServiceAssignment4Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServiceAssignment4Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServiceAssignment4Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServiceAssignment4Soap != null)
      ((javax.xml.rpc.Stub)webServiceAssignment4Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.rentacar.WebServiceAssignment4Soap getWebServiceAssignment4Soap() {
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.helloWorld();
  }
  
  public org.rentacar.GetAllCarsResponseGetAllCarsResult getAllCars() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.getAllCars();
  }
  
  public org.rentacar.GetAllPersonsResponseGetAllPersonsResult getAllPersons() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.getAllPersons();
  }
  
  public org.rentacar.GetAllOwnersResponseGetAllOwnersResult getAllOwners() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.getAllOwners();
  }
  
  public java.lang.String[] getAllCarsJava() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.getAllCarsJava();
  }
  
  public java.lang.String[] getAllOwnerJava() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.getAllOwnerJava();
  }
  
  public java.lang.String[] getAllPersonsJava() throws java.rmi.RemoteException{
    if (webServiceAssignment4Soap == null)
      _initWebServiceAssignment4SoapProxy();
    return webServiceAssignment4Soap.getAllPersonsJava();
  }
  
  
}