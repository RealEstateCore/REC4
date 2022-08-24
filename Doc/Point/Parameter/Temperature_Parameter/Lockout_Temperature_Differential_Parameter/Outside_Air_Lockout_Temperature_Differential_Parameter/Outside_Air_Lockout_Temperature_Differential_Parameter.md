[Point](../../../../Point.md) > [Parameter](../../../Parameter.md) > [Temperature_Parameter](../../Temperature_Parameter.md) > [Lockout_Temperature_Differential_Parameter](../Lockout_Temperature_Differential_Parameter.md) > [Outside_Air_Lockout_Temperature_Differential_Parameter](.)
# Outside_Air_Lockout_Temperature_Differential_Parameter

**Display name:** Outside Air Lockout Temperature Differential Parameter<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Lockout_Temperature_Differential_Parameter;1

---


## Child interfaces
* [High_Outside_Air_Lockout_Temperature_Differential_Parameter](High_Outside_Air_Lockout_Temperature_Differential_Parameter.md)
* [Low_Outside_Air_Lockout_Temperature_Differential_Parameter](Low_Outside_Air_Lockout_Temperature_Differential_Parameter.md)

---
## Relationships
### Inherited Relationships
* **dtmi:org:brickschema:schema:Brick:Point;1:** isPointOf
## Properties
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
