/**
 * WebServiceAssignment4Locator.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public class WebServiceAssignment4Locator extends org.apache.axis.client.Service implements org.rentacar.WebServiceAssignment4 {

    public WebServiceAssignment4Locator() {
    }


    public WebServiceAssignment4Locator(org.apache.axis.EngineConfiguration config) {
        super(config);
    }

    public WebServiceAssignment4Locator(java.lang.String wsdlLoc, javax.xml.namespace.QName sName) throws javax.xml.rpc.ServiceException {
        super(wsdlLoc, sName);
    }

    // Use to get a proxy class for WebServiceAssignment4Soap
    private java.lang.String WebServiceAssignment4Soap_address = "http://localhost:49780/WebServiceAssignment4.asmx";

    public java.lang.String getWebServiceAssignment4SoapAddress() {
        return WebServiceAssignment4Soap_address;
    }

    // The WSDD service name defaults to the port name.
    private java.lang.String WebServiceAssignment4SoapWSDDServiceName = "WebServiceAssignment4Soap";

    public java.lang.String getWebServiceAssignment4SoapWSDDServiceName() {
        return WebServiceAssignment4SoapWSDDServiceName;
    }

    public void setWebServiceAssignment4SoapWSDDServiceName(java.lang.String name) {
        WebServiceAssignment4SoapWSDDServiceName = name;
    }

    public org.rentacar.WebServiceAssignment4Soap getWebServiceAssignment4Soap() throws javax.xml.rpc.ServiceException {
       java.net.URL endpoint;
        try {
            endpoint = new java.net.URL(WebServiceAssignment4Soap_address);
        }
        catch (java.net.MalformedURLException e) {
            throw new javax.xml.rpc.ServiceException(e);
        }
        return getWebServiceAssignment4Soap(endpoint);
    }

    public org.rentacar.WebServiceAssignment4Soap getWebServiceAssignment4Soap(java.net.URL portAddress) throws javax.xml.rpc.ServiceException {
        try {
            org.rentacar.WebServiceAssignment4SoapStub _stub = new org.rentacar.WebServiceAssignment4SoapStub(portAddress, this);
            _stub.setPortName(getWebServiceAssignment4SoapWSDDServiceName());
            return _stub;
        }
        catch (org.apache.axis.AxisFault e) {
            return null;
        }
    }

    public void setWebServiceAssignment4SoapEndpointAddress(java.lang.String address) {
        WebServiceAssignment4Soap_address = address;
    }

    /**
     * For the given interface, get the stub implementation.
     * If this service has no port for the given interface,
     * then ServiceException is thrown.
     */
    public java.rmi.Remote getPort(Class serviceEndpointInterface) throws javax.xml.rpc.ServiceException {
        try {
            if (org.rentacar.WebServiceAssignment4Soap.class.isAssignableFrom(serviceEndpointInterface)) {
                org.rentacar.WebServiceAssignment4SoapStub _stub = new org.rentacar.WebServiceAssignment4SoapStub(new java.net.URL(WebServiceAssignment4Soap_address), this);
                _stub.setPortName(getWebServiceAssignment4SoapWSDDServiceName());
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
        if ("WebServiceAssignment4Soap".equals(inputPortName)) {
            return getWebServiceAssignment4Soap();
        }
        else  {
            java.rmi.Remote _stub = getPort(serviceEndpointInterface);
            ((org.apache.axis.client.Stub) _stub).setPortName(portName);
            return _stub;
        }
    }

    public javax.xml.namespace.QName getServiceName() {
        return new javax.xml.namespace.QName("http://rentacar.org/", "WebServiceAssignment4");
    }

    private java.util.HashSet ports = null;

    public java.util.Iterator getPorts() {
        if (ports == null) {
            ports = new java.util.HashSet();
            ports.add(new javax.xml.namespace.QName("http://rentacar.org/", "WebServiceAssignment4Soap"));
        }
        return ports.iterator();
    }

    /**
    * Set the endpoint address for the specified port name.
    */
    public void setEndpointAddress(java.lang.String portName, java.lang.String address) throws javax.xml.rpc.ServiceException {
        
if ("WebServiceAssignment4Soap".equals(portName)) {
            setWebServiceAssignment4SoapEndpointAddress(address);
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
