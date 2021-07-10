/**
 * WebServiceAss5Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public interface WebServiceAss5Soap extends java.rmi.Remote {
    public java.lang.String helloWorld() throws java.rmi.RemoteException;
    public java.lang.String addEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String eMail) throws java.rmi.RemoteException;
    public java.lang.String removeEmployee(java.lang.String no) throws java.rmi.RemoteException;
    public java.lang.String updateEmployee(java.lang.String no, java.lang.String firstName, java.lang.String lastName, java.lang.String jobTitle, java.lang.String eMail) throws java.rmi.RemoteException;
    public org.rentacar.Employee searchEmployee(java.lang.String no) throws java.rmi.RemoteException;
}
