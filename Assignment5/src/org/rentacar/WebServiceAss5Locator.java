/**
 * WebServiceAss5Locator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public class WebServiceAss5Locator extends org.apache.axis.client.Service implements org.rentacar.WebServiceAss5 {

    public WebServiceAss5Locator() {
    }


    public WebServiceAss5Locator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public WebServiceAss5Locator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for WebServiceAss5Soap
    private java.lang.String WebServiceAss5Soap_address = "http://localhost:49969/WebServiceAss5.asmx";

    public java.lang.String getWebServiceAss5SoapAddress() {
        return WebServiceAss5Soap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String WebServiceAss5SoapWSDDServiceName = "WebServiceAss5Soap";

    public java.lang.String getWebServiceAss5SoapWSDDServiceName() {
        return WebServiceAss5SoapWSDDServiceName;
    }

    public void setWebServiceAss5SoapWSDDServiceName(java.lang.String name) {
        WebServiceAss5SoapWSDDServiceName = name;
    }

    public org.rentacar.WebServiceAss5Soap getWebServiceAss5Soap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(WebServiceAss5Soap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getWebServiceAss5Soap(endpoint);
    }

    public org.rentacar.WebServiceAss5Soap getWebServiceAss5Soap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.rentacar.WebServiceAss5SoapStub _stub = new org.rentacar.WebServiceAss5SoapStub(portAddress, this);
            _stub.setPortName(getWebServiceAss5SoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setWebServiceAss5SoapEndpointAddress(java.lang.String address) {
        WebServiceAss5Soap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.rentacar.WebServiceAss5Soap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.rentacar.WebServiceAss5SoapStub _stub = new org.rentacar.WebServiceAss5SoapStub(new java.net.URL(WebServiceAss5Soap_address), this);
                _stub.setPortName(getWebServiceAss5SoapWSDDServiceName());
                return _stub;
            }
        }
        catch (java.lang.Throwable t) {
            throw new javax.xml.rpc.ServiceException(t);
        }
        throw new javax.xml.rpc.ServiceException("There is no stub implementation for the interface:  " + (serviceEndpointInterface == null ? "null" : serviceEndpointInterface.getName()));
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(javax.xml.namespace.QName portName, Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        if (portName == null) {
            return getPort(serviceEndpointInterface);
        }
        java.lang.String inputPortName = portName.getLocalPart();
        if ("WebServiceAss5Soap".equals(inputPortName)) {
            return getWebServiceAss5Soap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://rentacar.org/", "WebServiceAss5");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://rentacar.org/", "WebServiceAss5Soap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("WebServiceAss5Soap".equals(portName)) {
            setWebServiceAss5SoapEndpointAddress(address);
        }
        else 
{ // Unknown Port Name
            throw new javax.xml.rpc.ServiceException(" Cannot set Endpoint Address for Unknown Port" + portName);
        }
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(javax.xml.namespace.QName portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        setEndpointAddress(portName.getLocalPart(), address);
    }

}
