[Point](../../../../Point.md) > [Setpoint](../../../Setpoint.md) > [Temperature_Setpoint](../../Temperature_Setpoint.md) > [Air_Temperature_Setpoint](../Air_Temperature_Setpoint.md) > [Supply_Air_Temperature_Setpoint](.)
# Supply_Air_Temperature_Setpoint

**Display name:** Supply Air Temperature Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Supply_Air_Temperature_Setpoint;1

---


## Child interfaces
* [Effective_Supply_Air_Temperature_Setpoint](Effective_Supply_Air_Temperature_Setpoint.md)
* [Occupied_Supply_Air_Temperature_Setpoint](Occupied_Supply_Air_Temperature_Setpoint.md)
* [Supply_Air_Temperature_Cooling_Setpoint](Supply_Air_Temperature_Cooling_Setpoint.md)
* [Supply_Air_Temperature_Heating_Setpoint](Supply_Air_Temperature_Heating_Setpoint.md)
* [Unoccupied_Supply_Air_Temperature_Setpoint](../Unoccupied_Air_Temperature_Setpoint/Unoccupied_Supply_Air_Temperature_Setpoint.md)

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
