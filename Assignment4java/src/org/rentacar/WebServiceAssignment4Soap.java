/**
 * WebServiceAssignment4Soap.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public interface WebServiceAssignment4Soap extends java.rmi.Remote {
    public java.lang.String helloWorld() throws java.rmi.RemoteException;
    public org.rentacar.GetAllCarsResponseGetAllCarsResult getAllCars() throws java.rmi.RemoteException;
    public org.rentacar.GetAllPersonsResponseGetAllPersonsResult getAllPersons() throws java.rmi.RemoteException;
    public org.rentacar.GetAllOwnersResponseGetAllOwnersResult getAllOwners() throws java.rmi.RemoteException;
    public java.lang.String[] getAllCarsJava() throws java.rmi.RemoteException;
    public java.lang.String[] getAllOwnerJava() throws java.rmi.RemoteException;
    public java.lang.String[] getAllPersonsJava() throws java.rmi.RemoteException;
}
