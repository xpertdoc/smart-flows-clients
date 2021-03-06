/*
 * Xpertdoc SmartFlows
 * This describes the REST api for one Xpertdoc SmartFlows project
 *
 * OpenAPI spec version: 4.0.0
 * 
 *
 * NOTE: This class is auto generated by the swagger code generator program.
 * https://github.com/swagger-api/swagger-codegen.git
 * Do not edit the class manually.
 */


package xpertdoc.smartflows.client.model;

import com.google.gson.annotations.SerializedName;
import io.swagger.annotations.ApiModelProperty;

import java.util.ArrayList;
import java.util.List;
import java.util.Objects;

/**
 * FlowSwitchCases
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class FlowSwitchCases {
  @SerializedName("caseValue")
  private String caseValue = null;

  @SerializedName("caseBody")
  private List<FlowZone> caseBody = null;

  public FlowSwitchCases caseValue(String caseValue) {
    this.caseValue = caseValue;
    return this;
  }

   /**
   * Get caseValue
   * @return caseValue
  **/
  @ApiModelProperty(value = "")
  public String getCaseValue() {
    return caseValue;
  }

  public void setCaseValue(String caseValue) {
    this.caseValue = caseValue;
  }

  public FlowSwitchCases caseBody(List<FlowZone> caseBody) {
    this.caseBody = caseBody;
    return this;
  }

  public FlowSwitchCases addCaseBodyItem(FlowZone caseBodyItem) {
    if (this.caseBody == null) {
      this.caseBody = new ArrayList<FlowZone>();
    }
    this.caseBody.add(caseBodyItem);
    return this;
  }

   /**
   * Get caseBody
   * @return caseBody
  **/
  @ApiModelProperty(value = "")
  public List<FlowZone> getCaseBody() {
    return caseBody;
  }

  public void setCaseBody(List<FlowZone> caseBody) {
    this.caseBody = caseBody;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    FlowSwitchCases flowSwitchCases = (FlowSwitchCases) o;
    return Objects.equals(this.caseValue, flowSwitchCases.caseValue) &&
        Objects.equals(this.caseBody, flowSwitchCases.caseBody);
  }

  @Override
  public int hashCode() {
    return Objects.hash(caseValue, caseBody);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class FlowSwitchCases {\n");
    
    sb.append("    caseValue: ").append(toIndentedString(caseValue)).append("\n");
    sb.append("    caseBody: ").append(toIndentedString(caseBody)).append("\n");
    sb.append("}");
    return sb.toString();
  }

  /**
   * Convert the given object to string with each line indented by 4 spaces
   * (except the first line).
   */
  private String toIndentedString(java.lang.Object o) {
    if (o == null) {
      return "null";
    }
    return o.toString().replace("\n", "\n    ");
  }

}

