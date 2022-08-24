[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Differential_Setpoint](../../Differential_Setpoint.md) > [Differential_Pressure_Setpoint](../Differential_Pressure_Setpoint.md) > [Air_Differential_Pressure_Setpoint](Air_Differential_Pressure_Setpoint.md) > [Discharge_Air_Differential_Pressure_Setpoint](.)
# Discharge_Air_Differential_Pressure_Setpoint

**Display name:** Discharge Air Differential Pressure Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Discharge_Air_Differential_Pressure_Setpoint;1

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
