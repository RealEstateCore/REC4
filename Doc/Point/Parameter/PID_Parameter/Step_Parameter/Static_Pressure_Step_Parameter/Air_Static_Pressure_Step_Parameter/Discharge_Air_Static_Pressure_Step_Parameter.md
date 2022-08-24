[Point](../../../../../Point.md) > [Parameter](../../../../Parameter.md) > [PID_Parameter](../../../PID_Parameter.md) > [Step_Parameter](../../Step_Parameter.md) > [Static_Pressure_Step_Parameter](../Static_Pressure_Step_Parameter.md) > [Air_Static_Pressure_Step_Parameter](Air_Static_Pressure_Step_Parameter.md) > [Discharge_Air_Static_Pressure_Step_Parameter](.)
# Discharge_Air_Static_Pressure_Step_Parameter

**Display name:** Discharge Air Static Pressure Step Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Static_Pressure_Step_Parameter;1

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
|Name|Display name|Description|Schema|Writable|
|-|-|-|-|-|
|tags|**en**: Tags|**en**: Brick tags associated with this interface.|array (string)|False|
### Inherited Properties
* **dtmi:org:brickschema:schema:Brick:Point;1:** aggregate, customTags, externalIds, hasQuantity, hasSubstance, lastKnownValue, name
## Target Of
### Inherited
* Asset.hasPoint
* EquipmentCollection.hasPoint
* ActuationEvent.targetPoint
* ExceptionEvent.sourcePoint
* ObservationEvent.sourcePoint
* ServiceObject.producedBy
* Architecture.hasPoint
