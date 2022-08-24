[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Humidity_Setpoint](.)
# Humidity_Setpoint

**Display name:** Humidity Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Humidity_Setpoint;1

---


## Child interfaces
* [Building_Air_Humidity_Setpoint](Building_Air_Humidity_Setpoint.md)
* [Bypass_Air_Humidity_Setpoint](Bypass_Air_Humidity_Setpoint.md)
* [Discharge_Air_Humidity_Setpoint](Discharge_Air_Humidity_Setpoint.md)
* [Exhaust_Air_Humidity_Setpoint](Exhaust_Air_Humidity_Setpoint.md)
* [Mixed_Air_Humidity_Setpoint](Mixed_Air_Humidity_Setpoint.md)
* [Occupied_Humidity_Setpoint](Occupied_Humidity_Setpoint.md)
* [Outside_Air_Humidity_Setpoint](Outside_Air_Humidity_Setpoint.md)
* [Return_Air_Humidity_Setpoint](Return_Air_Humidity_Setpoint.md)
* [Supply_Air_Humidity_Setpoint](Supply_Air_Humidity_Setpoint.md)
* [Unoccupied_Humidity_Setpoint](Unoccupied_Humidity_Setpoint.md)
* [Zone_Air_Humidity_Setpoint](Zone_Air_Humidity_Setpoint.md)

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
