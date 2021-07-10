/**
 * WebService3Locator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public class WebService3Locator extends org.apache.axis.client.Service implements org.rentacar.WebService3 {

    public WebService3Locator() {
    }


    public WebService3Locator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public WebService3Locator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for WebService3Soap
    private java.lang.String WebService3Soap_address = "http://localhost:49848/WebService3.asmx";

    public java.lang.String getWebService3SoapAddress() {
        return WebService3Soap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String WebService3SoapWSDDServiceName = "WebService3Soap";

    public java.lang.String getWebService3SoapWSDDServiceName() {
        return WebService3SoapWSDDServiceName;
    }

    public void setWebService3SoapWSDDServiceName(java.lang.String name) {
        WebService3SoapWSDDServiceName = name;
    }

    public org.rentacar.WebService3Soap getWebService3Soap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(WebService3Soap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getWebService3Soap(endpoint);
    }

    public org.rentacar.WebService3Soap getWebService3Soap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.rentacar.WebService3SoapStub _stub = new org.rentacar.WebService3SoapStub(portAddress, this);
            _stub.setPortName(getWebService3SoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setWebService3SoapEndpointAddress(java.lang.String address) {
        WebService3Soap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.rentacar.WebService3Soap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.rentacar.WebService3SoapStub _stub = new org.rentacar.WebService3SoapStub(new java.net.URL(WebService3Soap_address), this);
                _stub.setPortName(getWebService3SoapWSDDServiceName());
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
        if ("WebService3Soap".equals(inputPortName)) {
            return getWebService3Soap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://rentacar.org/", "WebService3");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://rentacar.org/", "WebService3Soap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("WebService3Soap".equals(portName)) {
            setWebService3SoapEndpointAddress(address);
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
