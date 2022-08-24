[Point](../../Point.md) > [Sensor](../Sensor.md) > [Torque_Sensor](#)
# Torque_Sensor

**Display name:** Torque Sensor<br />
**DTMI:** dtmi:org:brickschema:schema:Brick:Torque_Sensor;1

---


## Child interfaces
* [Motor_Torque_Sensor](Motor_Torque_Sensor.md)

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
