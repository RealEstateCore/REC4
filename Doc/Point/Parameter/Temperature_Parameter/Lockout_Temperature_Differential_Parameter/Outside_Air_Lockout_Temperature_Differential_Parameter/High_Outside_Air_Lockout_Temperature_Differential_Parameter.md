[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Temperature_Parameter](../../Temperature_Parameter.md) > [Lockout_Temperature_Differential_Parameter](../Lockout_Temperature_Differential_Parameter.md) > [Outside_Air_Lockout_Temperature_Differential_Parameter](Outside_Air_Lockout_Temperature_Differential_Parameter.md) > [High_Outside_Air_Lockout_Temperature_Differential_Parameter](.)
# High_Outside_Air_Lockout_Temperature_Differential_Parameter

**Display name:** High Outside Air Lockout Temperature Differential Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:High_Outside_Air_Lockout_Temperature_Differential_Parameter;1

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
