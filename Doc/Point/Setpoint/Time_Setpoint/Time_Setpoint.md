[Point](../../Point.md) > [Setpoint](../Setpoint.md) > [Time_Setpoint](#)
# Time_Setpoint

**Display name:** Time Setpoint<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Time_Setpoint;1

---


## Child interfaces
* [Acceleration_Time_Setpoint](Acceleration_Time_Setpoint.md)
* [Deceleration_Time_Setpoint](Deceleration_Time_Setpoint.md)

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
