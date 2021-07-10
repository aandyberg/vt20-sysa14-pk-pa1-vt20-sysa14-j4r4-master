/**
 * GetAllPersonsResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public class GetAllPersonsResponse  implements java.io.Serializable {
    private org.rentacar.GetAllPersonsResponseGetAllPersonsResult getAllPersonsResult;

    public GetAllPersonsResponse() {
    }

    public GetAllPersonsResponse(
           org.rentacar.GetAllPersonsResponseGetAllPersonsResult getAllPersonsResult) {
           this.getAllPersonsResult = getAllPersonsResult;
    }


    /**
     * Gets the getAllPersonsResult value for this GetAllPersonsResponse.
     * 
     * @return getAllPersonsResult
     */
    public org.rentacar.GetAllPersonsResponseGetAllPersonsResult getGetAllPersonsResult() {
        return getAllPersonsResult;
    }


    /**
     * Sets the getAllPersonsResult value for this GetAllPersonsResponse.
     * 
     * @param getAllPersonsResult
     */
    public void setGetAllPersonsResult(org.rentacar.GetAllPersonsResponseGetAllPersonsResult getAllPersonsResult) {
        this.getAllPersonsResult = getAllPersonsResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetAllPersonsResponse)) return false;
        GetAllPersonsResponse other = (GetAllPersonsResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getAllPersonsResult==null && other.getGetAllPersonsResult()==null) || 
             (this.getAllPersonsResult!=null &&
              this.getAllPersonsResult.equals(other.getGetAllPersonsResult())));
        __equalsCalc = null;
        return _equals;
    }

    private boolean __hashCodeCalc = false;
    public synchronized int hashCode() {
        if (__hashCodeCalc) {
            return 0;
        }
        __hashCodeCalc = true;
        int _hashCode = 1;
        if (getGetAllPersonsResult() != null) {
            _hashCode += getGetAllPersonsResult().hashCode();
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetAllPersonsResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://rentacar.org/", ">GetAllPersonsResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getAllPersonsResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://rentacar.org/", "GetAllPersonsResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://rentacar.org/", ">>GetAllPersonsResponse>GetAllPersonsResult"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        typeDesc.addFieldDesc(elemField);
    }

    /**
     * Return type metadata object
     */
    public static org.apache.axis.description.TypeDesc getTypeDesc() {
        return typeDesc;
    }

    /**
     * Get Custom Serializer
     */
    public static org.apache.axis.encoding.Serializer getSerializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanSerializer(
            _javaType, _xmlType, typeDesc);
    }

    /**
     * Get Custom Deserializer
     */
    public static org.apache.axis.encoding.Deserializer getDeserializer(
           java.lang.String mechType, 
           java.lang.Class _javaType,  
           javax.xml.namespace.QName _xmlType) {
        return 
          new  org.apache.axis.encoding.ser.BeanDeserializer(
            _javaType, _xmlType, typeDesc);
    }

}
