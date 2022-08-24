[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Zone_Air_Temperature_Setpoint](#)
# Zone_Air_Temperature_Setpoint

**Display name:** Zone Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Zone_Air_Temperature_Setpoint;1

---


## Child interfaces
* [Effective_Zone_Air_Temperature_Setpoint](Effective_Zone_Air_Temperature_Setpoint.md)
* [Occupied_Zone_Air_Temperature_Setpoint](Occupied_Zone_Air_Temperature_Setpoint.md)
* [Unoccupied_Zone_Air_Temperature_Setpoint](Unoccupied_Zone_Air_Temperature_Setpoint.md)
* [Zone_Air_Cooling_Temperature_Setpoint](Zone_Air_Cooling_Temperature_Setpoint.md)
* [Zone_Air_Heating_Temperature_Setpoint](Zone_Air_Heating_Temperature_Setpoint.md)

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
