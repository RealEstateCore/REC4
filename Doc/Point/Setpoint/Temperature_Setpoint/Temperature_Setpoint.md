[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Temperature_Setpoint](.)
# Temperature_Setpoint

**Display name:** Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Temperature_Setpoint;1

---


## Child interfaces
* [Schedule_Temperature_Setpoint](Schedule_Temperature_Setpoint.md)
* [Temperature_Deadband_Setpoint](Temperature_Deadband_Setpoint/Temperature_Deadband_Setpoint.md)
* [Air_Temperature_Setpoint](Air_Temperature_Setpoint/Air_Temperature_Setpoint.md)
* [Cooling_Temperature_Setpoint](Cooling_Temperature_Setpoint/Cooling_Temperature_Setpoint.md)
* [Heating_Temperature_Setpoint](Heating_Temperature_Setpoint/Heating_Temperature_Setpoint.md)
* [Radiant_Panel_Temperature_Setpoint](Radiant_Panel_Temperature_Setpoint/Radiant_Panel_Temperature_Setpoint.md)
* [Water_Temperature_Setpoint](Water_Temperature_Setpoint/Water_Temperature_Setpoint.md)

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
