package org.rentacar;

public class WebServiceAss6SoapProxy implements org.rentacar.WebServiceAss6Soap {
  private String _endpoint = null;
  private org.rentacar.WebServiceAss6Soap webServiceAss6Soap = null;
  
  public WebServiceAss6SoapProxy() {
    _initWebServiceAss6SoapProxy();
  }
  
  public WebServiceAss6SoapProxy(String endpoint) {
    _endpoint = endpoint;
    _initWebServiceAss6SoapProxy();
  }
  
  private void _initWebServiceAss6SoapProxy() {
    try {
      webServiceAss6Soap = (new org.rentacar.WebServiceAss6Locator()).getWebServiceAss6Soap();
      if (webServiceAss6Soap != null) {
        if (_endpoint != null)
          ((javax.xml.rpc.Stub)webServiceAss6Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
        else
          _endpoint = (String)((javax.xml.rpc.Stub)webServiceAss6Soap)._getProperty("javax.xml.rpc.service.endpoint.address");
      }
      
    }
    catch (javax.xml.rpc.ServiceException serviceException) {}
  }
  
  public String getEndpoint() {
    return _endpoint;
  }
  
  public void setEndpoint(String endpoint) {
    _endpoint = endpoint;
    if (webServiceAss6Soap != null)
      ((javax.xml.rpc.Stub)webServiceAss6Soap)._setProperty("javax.xml.rpc.service.endpoint.address", _endpoint);
    
  }
  
  public org.rentacar.WebServiceAss6Soap getWebServiceAss6Soap() {
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap;
  }
  
  public java.lang.String helloWorld() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.helloWorld();
  }
  
  public java.lang.String getAllIndexes() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllIndexes();
  }
  
  public java.lang.String getAllKeys() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllKeys();
  }
  
  public java.lang.String getAllTableConstraints() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllTableConstraints();
  }
  
  public java.lang.String getAllColumnsFromEmp1() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllColumnsFromEmp1();
  }
  
  public java.lang.String getAllColumnsFromEmp2() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllColumnsFromEmp2();
  }
  
  public java.lang.String getAllTablesDB1() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllTablesDB1();
  }
  
  public java.lang.String getAllTablesDB2() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getAllTablesDB2();
  }
  
  public java.lang.String getNameAbsentMost() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getNameAbsentMost();
  }
  
  public java.lang.String getInfoEmpSickness2004() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getInfoEmpSickness2004();
  }
  
  public java.lang.String getInfoFromEmpAndRelatives() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getInfoFromEmpAndRelatives();
  }
  
  public java.lang.String getMetaDataFromEmpAndRelated() throws java.rmi.RemoteException{
    if (webServiceAss6Soap == null)
      _initWebServiceAss6SoapProxy();
    return webServiceAss6Soap.getMetaDataFromEmpAndRelated();
  }
  
  
}