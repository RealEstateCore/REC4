[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Outside_Air_Temperature_Setpoint](#)
# Outside_Air_Temperature_Setpoint

**Display name:** Outside Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Outside_Air_Temperature_Setpoint;1

---


## Child interfaces
* [Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint](Disable_Hot_Water_System_Outside_Air_Temperature_Setpoint.md)
* [Enable_Hot_Water_System_Outside_Air_Temperature_Setpoint](Enable_Hot_Water_System_Outside_Air_Temperature_Setpoint.md)
* [Low_Outside_Air_Temperature_Enable_Setpoint](Low_Outside_Air_Temperature_Enable_Setpoint.md)
* [Open_Heating_Valve_Outside_Air_Temperature_Setpoint](Open_Heating_Valve_Outside_Air_Temperature_Setpoint.md)
* [Outside_Air_Lockout_Temperature_Setpoint](Outside_Air_Lockout_Temperature_Setpoint.md)

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
