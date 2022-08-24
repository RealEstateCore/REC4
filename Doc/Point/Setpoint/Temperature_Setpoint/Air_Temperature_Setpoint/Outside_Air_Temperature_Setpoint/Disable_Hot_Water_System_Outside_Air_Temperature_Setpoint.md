[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Outside_Air_Temperature_Setpoint](Outside_Air_Temperature_Setpoint.md) > [Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint](.)
# Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint

**Display name:** Disable Hot Water System Outside Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint;1

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
