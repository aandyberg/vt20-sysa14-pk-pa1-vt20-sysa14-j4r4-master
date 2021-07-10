/**
 * GetAllCarsJavaResponse.java
 *
 * This file was auto-generated from WSDL
 * by the Apache Axis 1.4 Apr 22, 2006 (06:55:48 PDT) WSDL2Java emitter.
 */

package org.rentacar;

public class GetAllCarsJavaResponse  implements java.io.Serializable {
    private java.lang.String[] getAllCarsJavaResult;

    public GetAllCarsJavaResponse() {
    }

    public GetAllCarsJavaResponse(
           java.lang.String[] getAllCarsJavaResult) {
           this.getAllCarsJavaResult = getAllCarsJavaResult;
    }


    /**
     * Gets the getAllCarsJavaResult value for this GetAllCarsJavaResponse.
     * 
     * @return getAllCarsJavaResult
     */
    public java.lang.String[] getGetAllCarsJavaResult() {
        return getAllCarsJavaResult;
    }


    /**
     * Sets the getAllCarsJavaResult value for this GetAllCarsJavaResponse.
     * 
     * @param getAllCarsJavaResult
     */
    public void setGetAllCarsJavaResult(java.lang.String[] getAllCarsJavaResult) {
        this.getAllCarsJavaResult = getAllCarsJavaResult;
    }

    private java.lang.Object __equalsCalc = null;
    public synchronized boolean equals(java.lang.Object obj) {
        if (!(obj instanceof GetAllCarsJavaResponse)) return false;
        GetAllCarsJavaResponse other = (GetAllCarsJavaResponse) obj;
        if (obj == null) return false;
        if (this == obj) return true;
        if (__equalsCalc != null) {
            return (__equalsCalc == obj);
        }
        __equalsCalc = obj;
        boolean _equals;
        _equals = true && 
            ((this.getAllCarsJavaResult==null && other.getGetAllCarsJavaResult()==null) || 
             (this.getAllCarsJavaResult!=null &&
              java.util.Arrays.equals(this.getAllCarsJavaResult, other.getGetAllCarsJavaResult())));
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
        if (getGetAllCarsJavaResult() != null) {
            for (int i=0;
                 i<java.lang.reflect.Array.getLength(getGetAllCarsJavaResult());
                 i++) {
                java.lang.Object obj = java.lang.reflect.Array.get(getGetAllCarsJavaResult(), i);
                if (obj != null &&
                    !obj.getClass().isArray()) {
                    _hashCode += obj.hashCode();
                }
            }
        }
        __hashCodeCalc = false;
        return _hashCode;
    }

    // Type metadata
    private static org.apache.axis.description.TypeDesc typeDesc =
        new org.apache.axis.description.TypeDesc(GetAllCarsJavaResponse.class, true);

    static {
        typeDesc.setXmlType(new javax.xml.namespace.QName("http://rentacar.org/", ">getAllCarsJavaResponse"));
        org.apache.axis.description.ElementDesc elemField = new org.apache.axis.description.ElementDesc();
        elemField.setFieldName("getAllCarsJavaResult");
        elemField.setXmlName(new javax.xml.namespace.QName("http://rentacar.org/", "getAllCarsJavaResult"));
        elemField.setXmlType(new javax.xml.namespace.QName("http://www.w3.org/2001/XMLSchema", "string"));
        elemField.setMinOccurs(0);
        elemField.setNillable(false);
        elemField.setItemQName(new javax.xml.namespace.QName("http://rentacar.org/", "string"));
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
