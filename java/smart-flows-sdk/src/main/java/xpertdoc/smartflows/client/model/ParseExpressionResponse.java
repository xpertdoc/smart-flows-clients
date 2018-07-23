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
 * ParseExpressionResponse
 */
@javax.annotation.Generated(value = "xpertdoc.smartflows.codegen.languages.JavaClientCodegen", date = "2018-05-22T10:07:28.195+02:00")
public class ParseExpressionResponse {
  @SerializedName("value")
  private String value = null;

  @SerializedName("indented")
  private Boolean indented = null;

  @SerializedName("errors")
  private List<ParseExpressionResponseErrors> errors = null;

  public ParseExpressionResponse value(String value) {
    this.value = value;
    return this;
  }

   /**
   * Get value
   * @return value
  **/
  @ApiModelProperty(value = "")
  public String getValue() {
    return value;
  }

  public void setValue(String value) {
    this.value = value;
  }

  public ParseExpressionResponse indented(Boolean indented) {
    this.indented = indented;
    return this;
  }

   /**
   * Get indented
   * @return indented
  **/
  @ApiModelProperty(value = "")
  public Boolean isIndented() {
    return indented;
  }

  public void setIndented(Boolean indented) {
    this.indented = indented;
  }

  public ParseExpressionResponse errors(List<ParseExpressionResponseErrors> errors) {
    this.errors = errors;
    return this;
  }

  public ParseExpressionResponse addErrorsItem(ParseExpressionResponseErrors errorsItem) {
    if (this.errors == null) {
      this.errors = new ArrayList<ParseExpressionResponseErrors>();
    }
    this.errors.add(errorsItem);
    return this;
  }

   /**
   * Get errors
   * @return errors
  **/
  @ApiModelProperty(value = "")
  public List<ParseExpressionResponseErrors> getErrors() {
    return errors;
  }

  public void setErrors(List<ParseExpressionResponseErrors> errors) {
    this.errors = errors;
  }


  @Override
  public boolean equals(java.lang.Object o) {
    if (this == o) {
      return true;
    }
    if (o == null || getClass() != o.getClass()) {
      return false;
    }
    ParseExpressionResponse parseExpressionResponse = (ParseExpressionResponse) o;
    return Objects.equals(this.value, parseExpressionResponse.value) &&
        Objects.equals(this.indented, parseExpressionResponse.indented) &&
        Objects.equals(this.errors, parseExpressionResponse.errors);
  }

  @Override
  public int hashCode() {
    return Objects.hash(value, indented, errors);
  }


  @Override
  public String toString() {
    StringBuilder sb = new StringBuilder();
    sb.append("class ParseExpressionResponse {\n");
    
    sb.append("    value: ").append(toIndentedString(value)).append("\n");
    sb.append("    indented: ").append(toIndentedString(indented)).append("\n");
    sb.append("    errors: ").append(toIndentedString(errors)).append("\n");
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
